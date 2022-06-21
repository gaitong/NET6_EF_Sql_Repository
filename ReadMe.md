# NET6 + EF + SQLSERVER + Repository
## Installation
```sh
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
```

1.สร้าง class DataContext
```sh
public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }

        public DbSet<Crypto> Crypto { get; set; }
    }
```

	
2.เพิ่ม appsetting
```sh
"ConnectionStrings": {
    "ConnectionString": "Server=(localdb)\\MSSQLLocalDB;Database=Crypto;User Id=sa;Password=P@ssw0rd;"
  }
```


3.เพิ่มไฟล์ใน program.cs
```sh
builder.Services.AddDbContext<MyWorldDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});
```