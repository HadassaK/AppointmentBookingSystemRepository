from flask import Blueprint, request
from app.api.schemas import MessageRequest
from app.services.message_service import send_message

api = Blueprint("api", __name__)

@api.route("/send/<message_type>", methods=["POST"])
def send(message_type: str):
    data = MessageRequest(**request.json)
    send_message(message_type, data)
    return {"status": "sent"}, 200

from app.api.auth import authenticate

@api.before_request
def before_request():
    authenticate()

@api.route("/health")
def health():
    return {"status": "ok"}

