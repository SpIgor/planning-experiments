from Elements.TimeElement import TimeElement


class Generator(TimeElement):
    def __init__(self, rand_func, param1, param2):
        super().__init__(rand_func, param1, param2)
        self.generated = 0
        self.working_time = 0
