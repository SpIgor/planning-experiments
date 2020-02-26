from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *

from math import sqrt, log
from random import random

import sys

from ui_mainwindow import Ui_MainWindow
from Elements.ModellingController import ModellingController


class MainWindow(QMainWindow, Ui_MainWindow):
    @staticmethod
    def normal(m, sigma):
        r_sum = 0
        for i in range(1000):
            r_sum += random()
        r_sum -= 500
        return sigma * sqrt(12 / 1000) * r_sum + m

    @staticmethod
    def relay(sigma, extra_param):
        return sqrt(((-2) * pow(sigma, 2)) * log(1 - random()))

    def __init__(self):
        super(MainWindow, self).__init__()
        self.setupUi(self)

        self.controller = None

        self.start_modelling_btn.pressed.connect(self.start_modelling)
        self.show()

    def start_modelling(self):
        gen_param1 = self.gen_sigma_box.value()
        gen_param2 = self.gen_intense_box.value()

        proc_param1 = self.oa_m_box.value()
        proc_param2 = self.oa_sigma_box.value()

        modelling_time = self.modelling_time_box.value()

        self.controller = ModellingController(self.relay, gen_param1, gen_param2, self.normal, proc_param1, proc_param2,
                                              modelling_time)

        print(self.controller.start_modelling())


if __name__ == '__main__':
    app = QApplication([])
    window = MainWindow()
    sys.exit(app.exec())

    # for i in range(100):
        # print(MainWindow.relay(0.5, 0))
        # print(MainWindow.normal(1, 0.3))
        # pass
