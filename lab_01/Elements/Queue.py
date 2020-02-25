class Queue:
    @property
    def counter(self):
        return self.__counter

    @counter.setter
    def counter(self, value):
        self.__counter = value

    def __init__(self):
        self.counter = 0

    def enqueue(self):
        self.counter += 1

    def dequeue(self):
        if self.counter <= 0:
            return False
        else:
            self.counter -= 1
            return True
