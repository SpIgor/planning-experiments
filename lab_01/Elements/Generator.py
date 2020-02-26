from Elements.TimeElement import TimeElement


class Generator(TimeElement):
    def __init__(self, rand_func, param1, param2, queue):
        super().__init__(rand_func, param1, param2)
        self.generated = 0
        self.queue = queue

    def generate_element(self):
        self.generated += 1
        self.queue.enqueue()
        return self.generate_delay()
