from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select
import time
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from Assigment2Xpaths import Paths


class EbayAssignment:

    def setup(self):
        base_url = "https://www.ebay.com/"
        global driver
        driver = webdriver.Firefox()
        driver.maximize_window()
        driver.get(base_url)
        driver.implicitly_wait(10)

    def searchProduct(self, porduct, category):

        search_bar=driver.find_element(By.XPATH, Paths.xpath_search_bar)
        search_bar.send_keys(porduct)
        category_selection =Select(driver.find_element(By.XPATH, Paths.xpath_category_selection))
        category_selection.select_by_visible_text(category)
        btn_search=driver.find_element(By.XPATH, Paths.xpath_btn_search)
        btn_search.click()
        wait = WebDriverWait(driver, 20)
        txt_product_result = wait.until(EC.visibility_of_element_located((By.CSS_SELECTOR, Paths.xpath_product_result)))
        print( f"The result is {txt_product_result.text}")

    def getNproduct(self, productN):
        xpath_n_product = f"//*[@id='srp-river-results']/ul/li[{productN}]"
        nth_product = driver.find_element(By.XPATH, xpath_n_product).text
        print(nth_product)
        print("===================================")

    def getAllProducts(self):

        xpath_all_products = driver.find_elements(By.XPATH, Paths.xpath_all_products)

        for item in xpath_all_products:
            driver.execute_script("return arguments[0].scrollIntoView();", item)
            time.sleep(0.5)
            print(item.text)
            print("---------------------------")

    def tearDown(self):
        driver.quit()


function_call = EbayAssignment()
function_call.setup()
function_call.searchProduct("Apple Watch", "Jewelry & Watches")
function_call.getNproduct(4)
function_call.getAllProducts()
function_call.tearDown()