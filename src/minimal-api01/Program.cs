using src.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Invoices for Minimal API
List<Invoice> Invoices= new List<Invoice>();

app.MapGet("/", () => "Welcome to Minimal Invoices API");
app.MapGet("/invoices", (HttpContext http) => {
      http.Response.StatusCode=201;
      http.Response.WriteAsJsonAsync<List<Invoice>>(Invoices);
});

app.MapGet("/invoices/{id}", (Guid id, HttpContext http) => {
     Invoice item =  Invoices.Find(i=>i.Id==id);
     if (item==null) {http.Response.StatusCode=404; return;}
     http.Response.StatusCode=201;
     http.Response.WriteAsJsonAsync<Invoice>(item);
});

app.MapDelete("/invoices/{id}", (Guid id,HttpContext http) => {
     Invoice item =  Invoices.Find(i=>i.Id==id);
     if (item==null) {http.Response.StatusCode=404; return;}
     Invoices.Remove(item);
     http.Response.StatusCode=201;
});

app.MapPost("/invoices/", (Invoice item, HttpContext http) => {
     if (item.CustomerName=="" || item.ProductDescription=="" || item.Value==0) 
     { 
         http.Response.StatusCode=401;
         return;
     }
     item.Id= Guid.NewGuid();
     Invoices.Add(item);
     http.Response.StatusCode=201;
});

app.Run();
