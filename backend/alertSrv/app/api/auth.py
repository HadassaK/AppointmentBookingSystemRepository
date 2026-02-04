from flask import request, abort, g

from app.config import Config

def authenticate():
    api_key = request.headers.get("X-API-KEY")

    if not api_key or api_key not in Config.API_KEYS:
        abort(401, description="Invalid API Key")

    # שמירת הלקוח בהקשר הבקשה
    g.client_name = Config.API_KEYS[api_key]
