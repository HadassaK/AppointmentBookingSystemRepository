class EmailProvider:
    def send(self, message):
        recipient = message.target
        header = message.header
        content = message.content

        send_email(header, content, recipient=recipient)
        print(f"[Email] To {message.target}: {message.content}")


import os
import smtplib
from email.mime.text import MIMEText
from typing import Optional
from app.config import Config

def send_email(subject: str, body: str, recipient: Optional[str] = None):
    EMAIL_USER = Config.EmailUser
    EMAIL_PASS = Config.EMAIL_PASS
    recipient = recipient  # orDEFAULT_RECIPIENT#
    if not EMAIL_USER or not EMAIL_PASS or not recipient:
        raise RuntimeError("Email configuration missing. Check .env values EMAIL_USER, EMAIL_PASS and TEST_RECIPIENT")

    msg = MIMEText(body)
    msg['Subject'] = subject
    msg['From'] = EMAIL_USER
    msg['To'] = recipient

    # Using Gmail SMTP as an example (SSL)
    with smtplib.SMTP_SSL('smtp.gmail.com', 465) as server:
        server.login(EMAIL_USER, EMAIL_PASS)
        server.sendmail(EMAIL_USER, recipient, msg.as_string())

