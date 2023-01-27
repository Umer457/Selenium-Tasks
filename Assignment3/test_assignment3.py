from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver import ActionChains
import time
from PIL import Image
from test_assignment3Xpaths import xpaths

class Test_DragAndDrop:

    def test_setup(self):
        global driver
        base_url = "https://jqueryui.com/droppable/"
        driver = webdriver.Firefox()
        driver.maximize_window()
        driver.get(base_url)
        driver.implicitly_wait(10)



    def test_dragDrop(self):

        driver.switch_to.frame(driver.find_element(By.XPATH, xpaths.xpath_frame_switch))
        drag_element = driver.find_element(By.XPATH, xpaths.xpath_drag_element)
        drop_element = driver.find_element(By.XPATH, xpaths.xpath_drop_element)
        ActionChains(driver).drag_and_drop(drag_element, drop_element).perform()
        time.sleep(5)


    def test_failiure(self):

        btn_sample = driver.find_element(By.XPATH, "/html/body/header/div/nav/ol/li[4]/a")
        if btn_sample:
            print("exists")
        else:
            assert btn_sample




    def test_tearDown(self):
        driver.get_screenshot_as_file("screenshot.png")
        screenshot = Image.open("screenshot.png")
        screenshot.show()
        driver.quit()


drag_drop_call = Test_DragAndDrop()
drag_drop_call.test_setup()
drag_drop_call.test_dragDrop()
drag_drop_call.test_tearDown()
