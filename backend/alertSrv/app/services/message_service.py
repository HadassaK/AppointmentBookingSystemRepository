from app.domain.message import Message
from app.infrastructure.provider_factory import get_provider

def send_message(message_type: str, data):
    message = Message(
        type=message_type,
        target=data.target,
        header=data.header,
        content=data.content
    )

    provider = get_provider(message.type)
    provider.send(message)
