from Elements.TimeElement import TimeElement


class Processor(TimeElement):
    def __init__(self, rand_func, param1, param2, queue):
        super().__init__(rand_func, param1, param2)
        self.queue = queue
        self.processing = False
        self.processed = 0

    def start_processing(self):
        if self.processing:
            self.queue.enqueue()
        else:
            self.generate_delay()
            self.processing = True

    def process_next(self):
        self.processed += 1
        self.processing = False
        if self.queue.dequeue():
            self.processing = True
            self.generate_delay()
