class HashTable:
    def __init__(self):
        self.buckets = {}

    def _get_bucket_index(self, key):
        return hash(key) % len(self.buckets)

    def add(self, key, value):
        index = self._get_bucket_index(key)
        if index not in self.buckets:
            self.buckets[index] = []
        else:
            # Check if key already exists in the bucket
            for k, _ in self.buckets[index]:
                if k == key:
                    raise ValueError("Key already exists")

        # Add key-value pair to the bucket
        self.buckets[index].append((key, value))

    def get(self, key):
        index = self._get_bucket_index(key)
        if index in self.buckets:
            for k, v in self.buckets[index]:
                if k == key:
                    return v
        raise KeyError("Key not found")

    def remove(self, key):
        index = self._get_bucket_index(key)
        if index in self.buckets:
            for i, (k, v) in enumerate(self.buckets[index]):
                if k == key:
                    del self.buckets[index][i]
                    return
        raise KeyError("Key not found")

table = HashTable()
table.add("apple", 5)
table.add("banana", 7)
table.add("orange", 3)

print("Value for 'apple':", table.get("apple"))
print("Value for 'banana':", table.get("banana"))
print("Value for 'orange':", table.get("orange"))

table.remove("apple")
print("Value for 'apple':", table.get("apple"))  # This will raise KeyError