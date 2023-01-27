from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
import time
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Assignment1Xpaths import Xpaths


class Methods:

    def setup(self):
        global driver
        base_url = "https://google.com"
        driver = webdriver.Firefox()
        driver.maximize_window()
        driver.get(base_url)
        driver.implicitly_wait(10)


    def google_navigation(self):

        search_bar = driver.find_element(By.XPATH, Xpaths.xpath_search_bar)
        search_bar.send_keys("Tintash")
        search_bar.send_keys(Keys.ENTER)




    def tintash_navigation(self):

        web_link = driver.find_element(By.XPATH, Xpaths.xpath_tintash_link)
        web_link.click()

        port_link = driver.find_element(By.XPATH, Xpaths.xpath_portfolio)
        port_link.click()
        driver.implicitly_wait(2)

        scroll_to_tabs = driver.find_element(By.XPATH, Xpaths.xpath_tabs_view)
        driver.execute_script("arguments[0].scrollIntoView()", scroll_to_tabs)
        time.sleep(2)

        solution_menu = driver.find_element(By.XPATH, Xpaths.xpath_solution_tab)
        solution_menu.click()


        first_option = driver.find_element(By.XPATH, Xpaths.xpath_solution_option)
        first_option.click()



        technology_menu = driver.find_element(By.XPATH, Xpaths.xpath_technology_tab)
        technology_menu.click()


        second_option = driver.find_element(By.XPATH, Xpaths.xpath_technology_option)
        second_option.click()



        industry_menu = driver.find_element(By.XPATH, Xpaths.xpath_industry_tab)
        industry_menu.click()


        third_option = driver.find_element(By.XPATH, Xpaths.xpath_industry_option)
        driver.execute_script("arguments[0].click();", third_option)



        btn_search = driver.find_element(By.XPATH, Xpaths.xpath_search_button)
        btn_search.click()


        wait = WebDriverWait(driver, 10)
        link_camaradly = wait.until(EC.presence_of_element_located((By.XPATH, Xpaths.xpath_camaradly)))
        assert link_camaradly
        link_camaradly.location_once_scrolled_into_view






    def tearDown(self):
        driver.quit()


function_call = Methods()
function_call.setup()
function_call.google_navigation()
function_call.tintash_navigation()
function_call.tearDown()
