from Elements.Generator import Generator
from Elements.Queue import Queue
from Elements.Processor import Processor


class ModellingController:
    @staticmethod
    def get_min_time_el_index(lst):
        min_time = lst[0].total_time
        min_index = 0
        for i in range(len(lst)):
            if lst[i].total_time < min_time:
                min_time = lst[i].total_time
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
        # current_time = self.gen.generate_element()
        # self.proc.total_time = current_time
        # self.proc.start_processing()
        # print('generator total time = {}\nprocessor total time = {}\n'
        #       'current modelling time = {}'.format(self.gen.total_time, self.proc.total_time, current_time))

        while current_time < self.modelling_time:
            current_time, index = self.get_min_time_el_index(lst)
            if isinstance(lst[index], Generator):
                print('generator')
                lst[index].generate_element()
            if isinstance(lst[index], Processor):
                print('processor')
                lst[index].process_next()

        print(self.gen.generated)
        print(self.proc.processed)
        return 'hello, world\n'
