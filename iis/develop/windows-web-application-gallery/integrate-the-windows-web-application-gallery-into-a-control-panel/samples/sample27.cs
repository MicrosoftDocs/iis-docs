// Verify SHA1 Hash
SHA1 sha1 = SHA1.Create();
byte[] hash = sha1.ComputeHash(File.ReadAllBytes(_downloadTempFile));
string hashString = hash.Aggregate("", (acc, value) => acc + value.ToString("X2"));
if (DownloadHash.ToUpperInvariant() != hashString) {
	File.Delete(_downloadTempFile);
	_downloadTempFile = null;
	throw new InvalidOperationException("The download file appears to be corrupt.");
}