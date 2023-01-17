from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver import ActionChains
import time
from Assignment3Xpaths import xpaths


class DragAndDrop:
    def setup(self):
        global driver
        base_url = "https://jqueryui.com/droppable/"
        driver = webdriver.Firefox()
        driver.maximize_window()
        driver.get(base_url)
        driver.implicitly_wait(10)

    def dragDrop(self):
        driver.switch_to.frame(driver.find_element(By.XPATH, xpaths.xpath_frame_switch))
        drag_element = driver.find_element(By.XPATH, xpaths.xpath_drag_element)
        drop_element = driver.find_element(By.XPATH, xpaths.xpath_drop_element)
        ActionChains(driver).drag_and_drop(drag_element, drop_element).perform()
        time.sleep(5)

    def tearDown(self):
        driver.quit()


drag_drop_call = DragAndDrop()
drag_drop_call.setup()
drag_drop_call.dragDrop()
drag_drop_call.tearDown()
