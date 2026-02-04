from pydantic import BaseModel

class MessageRequest(BaseModel):
    target: str     # טלפון / מייל
    header:str
    content: str
