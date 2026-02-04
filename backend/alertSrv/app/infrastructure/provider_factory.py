from app.infrastructure.sms_provider import SmsProvider
from app.infrastructure.whatsapp_provider import WhatsAppProvider
from app.infrastructure.email_provider import EmailProvider

def get_provider(message_type: str):
    if message_type == "sms":
        return SmsProvider()
    if message_type == "whatsapp":
        return WhatsAppProvider()
    if message_type == "email":
        return EmailProvider()

    raise ValueError(f"Unsupported message type: {message_type}")
