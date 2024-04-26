from cryptography.hazmat.backends import default_backend
from cryptography.hazmat.primitives.asymmetric import rsa
from cryptography.hazmat.primitives import serialization

# Generate RSA key pair
def generate_key_pair():
    private_key = rsa.generate_private_key(
        public_exponent=65537,
        key_size=2048,
        backend=default_backend()
    )
    public_key = private_key.public_key()
    return private_key, public_key

# Encrypt message using RSA public key
def encrypt_message(message, public_key):
    encrypted = public_key.encrypt(
        message.encode(),
        padding.PKCS1v15()
    )
    return encrypted

# Decrypt message using RSA private key
def decrypt_message(encrypted_message, private_key):
    decrypted = private_key.decrypt(
        encrypted_message,
        padding.PKCS1v15()
    )
    return decrypted.decode()

# Example usage
private_key, public_key = generate_key_pair()

message = "Hello, this is a secret message!"
print("Original Message:", message)

# Encrypt the message with the public key
encrypted_message = encrypt_message(message, public_key)
print("Encrypted Message:", encrypted_message)

# Decrypt the message with the private key
decrypted_message = decrypt_message(encrypted_message, private_key)
print("Decrypted Message:", decrypted_message)
