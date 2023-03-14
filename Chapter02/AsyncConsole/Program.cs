
HttpClient client = new();
HttpResponseMessage response =
    await client.GetAsync("http://www.microsoft.com");

WriteLine($"Microsoft's homepage has {response.Content.Headers.ContentLength} bytes");
