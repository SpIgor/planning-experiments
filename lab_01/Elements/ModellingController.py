from Elements.Generator import Generator
from Elements.Queue import Queue
from Elements.Processor import Processor


class ModellingController:
    @staticmethod
    def get_min_time_el_index(lst):
        min_time = lst[0].total_time
        min_index = 0
        for i, elem in enumerate(lst):
            if elem.total_time < min_time:
                if isinstance(elem, Processor) and elem.queue.counter <= 0:
                    continue
                min_time = elem.total_time
                min_index = i

        return min_time, min_index

    @property
    def modelling_time(self):
        return self.__modelling_time

    @modelling_time.setter
    def modelling_time(self, value):
        self.__modelling_time = value

    def __init__(self, gen_rand_func, gen_param1, gen_param2,
                 proc_rand_func, proc_param1, proc_param2, modelling_time):
        self.__modelling_time = modelling_time
        self.queue = Queue()
        self.gen = Generator(gen_rand_func, gen_param1, gen_param2, self.queue)
        self.proc = Processor(proc_rand_func, proc_param1, proc_param2, self.queue)

    def start_modelling(self):
        lst = [self.gen, self.proc]
        current_time = 0

        while current_time < self.modelling_time:
            current_time, index = self.get_min_time_el_index(lst)
            if isinstance(lst[index], Generator):
                lst[index].generate_element()
            if isinstance(lst[index], Processor):
                lst[index].process_next()

        gen_intense = self.gen.generated / self.gen.total_time
        oa_intense = self.proc.processed / self.proc.total_time

        return gen_intense, oa_intense
