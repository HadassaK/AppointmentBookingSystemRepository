from dataclasses import dataclass

@dataclass
class Message:
    type: str
    target: str
    header: str
    content: str
