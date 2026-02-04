class SmsProvider:
    def send(self, message):
        print(f"[SMS] To {message.target}: {message.content}")
