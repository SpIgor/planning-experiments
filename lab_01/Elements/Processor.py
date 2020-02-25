from Elements.TimeElement import TimeElement


class Processor(TimeElement):
    def __init__(self, rand_func, param1, param2, queue):
        super().__init__(rand_func, param1, param2)
        self.queue = queue
