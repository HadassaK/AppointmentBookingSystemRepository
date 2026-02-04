class WhatsAppProvider:
    def send(self, message):
        print(f"[WhatsApp] To {message.target}: {message.content}")
