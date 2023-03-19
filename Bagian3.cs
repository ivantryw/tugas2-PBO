// The Superclass
class Otomobil
{
    protected string Name;
    protected string Manufacture;
    protected int Year;
    protected int EngineCapacity;
    protected int CurrentSpeed;
    protected int MaxSpeed;
    protected double Fuel;
    protected double FuelPerSpeed = 0.3;

    public Otomobil(string name, string manufacture, int year, int engineCapacity, int maxSpeed, double fuel)
    {
        Name = name;
        Manufacture = manufacture;
        Year = year;
        EngineCapacity = engineCapacity;
        MaxSpeed = maxSpeed;
        Fuel = fuel;
    }

    public void ShowProperties()
    {
        Console.WriteLine($"Nama: {Name}");
        Console.WriteLine($"Manufaktur: {Manufacture}");
        Console.WriteLine($"Tahun: {Year}");
        Console.WriteLine($"Kapasitas: {EngineCapacity} cc\n");
    }

    public void ShowSpeed() => Console.WriteLine($"Kecepatan mobil {Name} saat ini adalah {CurrentSpeed}");
    public void ShowFuel() => Console.WriteLine($"Bensin mobil {Name} saat ini sebanyak {Fuel}");
    public void AddFuel(double fuel) => Fuel += fuel;

    public void Accelerate(int speed)
    {
        Fuel -= FuelPerSpeed * speed;
        if ( Fuel <= 0 )
        {
            Fuel = 0;
            Console.WriteLine("Bensin habis");
            return;
        }

        CurrentSpeed += speed;
        if (CurrentSpeed >= MaxSpeed) CurrentSpeed = MaxSpeed;
    }

    public void Break(int decelerationAmount = 5)
    {
        CurrentSpeed -= decelerationAmount;
        if (CurrentSpeed <= 0) CurrentSpeed = 0;
    }
}

// The Subclasses
class Sedan : Otomobil
{
    private string _driveTrain;
    private string? _style;

    public Sedan(string name, string manufacture, int year, int engineCapacity, int maxSpeed, double fuel, string driveTrain, string? style = null)
        : base(name, manufacture, year, engineCapacity, maxSpeed, fuel) 
    {
        _style = style;
        _driveTrain = driveTrain;
    }

    public new void ShowProperties()
    {
        base.ShowProperties();
        Console.WriteLine($"Drivetrain: {_driveTrain}");
        Console.WriteLine($"Style: {_style}");
    }

    public void EchoMode()
    {
        Console.WriteLine($"Mode hemat diaktifkan");
        FuelPerSpeed = 0.1;
    }
}

class Truk : Otomobil
{
    private string? _trailer;
    public Truk(string name, string manufacture, int year, int engineCapacity, int maxSpeed, double fuel, string? trailer = null)
        : base(name, manufacture, year, engineCapacity, maxSpeed, fuel) => _trailer = trailer;

    public new void ShowProperties()
    {
        base.ShowProperties();

        if (_trailer == null) _trailer = "Tidak ada";
        Console.WriteLine($"Trailer: {_trailer}");
    }

    public void AttachTrailer(string trailer) 
    {
        if (_trailer != null)
        {
            Console.WriteLine($"Truk {Name} sudah terpasang dengan trailer {_trailer}");
            return;
        }

        _trailer = trailer;
        Console.WriteLine($"Trailer {trailer} berhasil terpasang di truk {Name}.");
    }

    public void DetachTrailer()
    {
        if (_trailer == null)
        {
            Console.WriteLine($"Truk {Name} tidak terhubung dengan trailer apapun.");
            return;
        }

        Console.WriteLine($"Trailer {_trailer} berhasil dilepas dari truk {Name}.");
        _trailer = null;
    }
}

class SepedaMotor : Otomobil
{
    public SepedaMotor(string name, string manufacture, int year, int engineCapacity, int maxSpeed, double fuel)
        : base(name, manufacture, year, engineCapacity, maxSpeed, fuel) { }

    public new void ShowSpeed() => Console.WriteLine($"Kecepatan sepeda motor {Name} saat ini adalah {CurrentSpeed}");

    public void Wheelie() => Console.WriteLine($"Sepeda motor {Name} sedang wheelie");
    
    public void Cornering() => Console.WriteLine($"Sepeda motor {Name} sedang cornering");
}