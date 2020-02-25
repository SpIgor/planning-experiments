class TimeElement:

    def __init__(self, rand_func, param1, param2):
        self.rand_func = rand_func
        self.param1 = param1
        self.param2 = param2
        self.__total_time = 0
        self.__remaining_time = 0

    @property
    def total_time(self):
        return self.__total_time

    @total_time.setter
    def total_time(self, value):
        self.__total_time = value

    @property
    def remaining_time(self):
        return self.__remaining_time

    @remaining_time.setter
    def remaining_time(self, value):
        self.__remaining_time = value

    def generate_delay(self):
        self.remaining_time = self.rand_func(
            self.param1, self.param2)
        self.total_time += self.remaining_time
