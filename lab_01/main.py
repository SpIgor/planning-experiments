import sys
from math import sqrt, log, pi
from random import random

from PyQt5.QtWidgets import *

from Elements.ModellingController import ModellingController
from ui_mainwindow import Ui_MainWindow


class MainWindow(QMainWindow, Ui_MainWindow):
    @staticmethod
    def normal(m, sigma):
        res = 0
        while res <= 0:
            r_sum = 0
            for i in range(1000):
                r_sum += random()
            r_sum -= 500
            res = sigma * sqrt(12 / 1000) * r_sum + m

        return res

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
        gen_param2 = None
        if self.gen_sigma_btn.isChecked():
            gen_param1 = self.gen_sigma_box.value()
            expected_gen_intense = (float(1) / (sqrt(pi / 2) * gen_param1))
        else:
            expected_gen_intense = self.gen_intense_box.value()
            gen_param1 = (float(1) / (sqrt(pi / 2) * expected_gen_intense))

        proc_param1 = self.oa_m_box.value()
        proc_param2 = self.oa_sigma_box.value()

        expected_oa_intense = (float(1) / proc_param1)

        modelling_time = self.modelling_time_box.value()

        self.controller = ModellingController(self.relay, gen_param1, gen_param2, self.normal, proc_param1, proc_param2,
                                              modelling_time)

        self.expected_gen_intense.setText('%.2f' % expected_gen_intense)
        self.expected_oa_intense.setText('%.2f' % expected_oa_intense)

        gen_intense, oa_intense = self.controller.start_modelling()

        self.real_gen_intense.setText('%.2f' % gen_intense)
        self.real_oa_intense.setText('%.2f' % oa_intense)


if __name__ == '__main__':
    app = QApplication([])
    window = MainWindow()
    sys.exit(app.exec())
