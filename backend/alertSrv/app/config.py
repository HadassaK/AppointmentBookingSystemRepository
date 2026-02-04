import os

class Config:
    DEBUG = False
    API_KEYS = {
        "client_abc12345": "make",
        "client_xyz789": "crm",
        "abc": "abc"
    }
    EMAIL_PASS = "nkgt tdih bmyd gkpl"
    EmailUser = "smartcart.prod.env@gmail.com"

class DevConfig(Config):
    DEBUG = True

class ProdConfig(Config):
    DEBUG = False
