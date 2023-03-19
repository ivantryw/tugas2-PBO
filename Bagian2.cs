class MobilSedan
{
    private string _name;
    private string _manufacture;
    private int _year;
    private int _capacity;
    private int _currentSpeed;
    private int _maxSpeed;

    public MobilSedan(string name, string manufacture, int year, int capacity, int maxSpeed)
    {
        _name = name;
        _manufacture = manufacture;
        _year = year;
        _capacity = capacity;
        _maxSpeed = maxSpeed;
    }

    public void ShowProperties()
    {
        Console.WriteLine($"Nama: {_name}");
        Console.WriteLine($"Manufaktur: {_manufacture}");
        Console.WriteLine($"Tahun: {_year}");
        Console.WriteLine($"Kapasitas: {_capacity} cc\n");
    }

    public void Accelerate(int speed)
    {
        _currentSpeed += speed;

        if ( _currentSpeed >= _maxSpeed )
        {
            _currentSpeed = _maxSpeed;
            Console.WriteLine($"Mobil sedan {_name} telah mencapai kecepatan maksimum.");
        }
        Console.WriteLine($"Mobil sedan {_name} sedang berjalan dengan kecepatan {_currentSpeed} km/jam");
    }

    public void Break()
    {
        int decelerationAmount = 5;
        _currentSpeed -= decelerationAmount;

        if (_currentSpeed <= 0)
        {
            _currentSpeed = 0;
            Console.WriteLine($"Mobil sedan {_name} sedang berhenti");
        }

        Console.WriteLine($"Kecepatan mobil sedan {_name} saat ini adalah {_currentSpeed}");
    }
}

class Ikan
{
    private string _name;
    private int _size;
    private string _habitat;
    private int _energy;
    private int _maxEnergy;

    public Ikan(string name, int size, string habitat, int energy, int maxEnergy)
    {
        _name = name;
        _size = size;
        _habitat = habitat;
        _energy = energy;
        _maxEnergy = maxEnergy;
    }

    public void ShowProperties()
    {
        Console.WriteLine($"Nama: {_name}");
        Console.WriteLine($"_size: {_size} cm");
        Console.WriteLine($"_habitat: {_habitat}\n");
    }

    public void ShowEnergy() => Console.WriteLine($"Energi: {_energy}");

    public void Swim(int distance)
    {
        int energyPerMeter = 2;

        if (_energy - (energyPerMeter * distance) <= 0)
        {
            Console.WriteLine($"Energi ikan {_name} tidak cukup.");
            return;
        }

        _energy -= (energyPerMeter * distance);
        Console.WriteLine($"Ikan {_name} sedang berenang sejauh {distance} m");
    }

    public void Eat(int energyAmount)
    {
        Console.WriteLine($"Ikan {_name} sedang makan");

        _energy += energyAmount;
        if (_energy >= _maxEnergy) _energy = _maxEnergy;

        Console.WriteLine($"Energi ikan {_name} ditambah sebesar {energyAmount}.");
    }

    public void Rest()
    {
        int restEnergy = 50;

        Console.WriteLine($"Ikan {_name} sedang beristirahat");

        _energy += restEnergy;
        Console.WriteLine($"Ikan {_name} telah dipulihkan sebesar {restEnergy}");

        if (_energy >= _maxEnergy ) _energy = _maxEnergy;
        Console.WriteLine($"Tenaga ikan {_name} saat ini adalah {_energy}");
    }
}

class PionCatur
{
    private string _name;
    private bool _isWhite;
    private readonly string _startLocation;
    private string _currentLocation;

    public PionCatur(string name, bool isWhite, string startLocation)
    {
        _name = name;
        _isWhite = isWhite;
        _startLocation = startLocation.ToUpper();
        _currentLocation = startLocation.ToUpper();
    }

    public string GetLocation() => _currentLocation;
    public string GetStartLocation() => _startLocation;
    public string GetName() => _name;

    public char GetColumn()
    {
        char Column = _currentLocation[0];
        return Column;
    }

    public int GetRow()
    {
        int Row = int.Parse(_currentLocation[1].ToString());
        return Row;
    }

    public void MoveForward()
    {
        char Column = GetColumn();
        int Row = GetRow();

        if (_isWhite) Row++;
        else Row--;

        _currentLocation = Column + Row.ToString();
    }

    public void CaptureToLeft()
    {
        char Column = GetColumn();
        int Row = GetRow();

        if (_isWhite && Column <= 'A')
        {
            Console.WriteLine("Forbidden Move!");
            return;
        }
        else if (!_isWhite && Column >= 'H')
        {
            Console.WriteLine("Forbidden Move!");
            return;
        }

        if (_isWhite) Row++;
        else Row--;

        if (_isWhite) Column--;
        else Column++;

        _currentLocation = Column + Row.ToString();
    }

    public void CaptureToRight()
    {
        char Column = GetColumn();
        int Row = GetRow();

        if (_isWhite && Column >= 'H')
        {
            Console.WriteLine("Forbidden Move!");
            return;
        }
        else if (!_isWhite && Column <= 'A')
        {
            Console.WriteLine("Forbidden Move!");
            return;
        }

        if (_isWhite) Row++;
        else Row--;

        if (_isWhite) Column++;
        else Column--;

        _currentLocation = Column + Row.ToString();
    }
   
    public void Promote(string pieceName) => _name = pieceName;
}
class RekeningBank
{
    private string _namaNasabah;
    private int _noRekening;
    private double _saldo;
    private string _tglPembuatan;

    public RekeningBank(string namaNasabah, int noRekening, double saldo, string tglPembuatan)
    {
        _namaNasabah = namaNasabah;
        _noRekening = noRekening;
        _saldo = saldo;
        _tglPembuatan = tglPembuatan;
    }

    public string GetNama() => _namaNasabah;
    public int GetNoRekening() => _noRekening;
    public double GetSaldo() => _saldo;
    public string GetTglPembuatan() => _tglPembuatan;

    public void Setor(double nominal) => _saldo += nominal;

    public void Tarik(double nominal)
    {
        if ((_saldo - nominal) <= 0)
        {
            Console.WriteLine("Maaf, saldo tidak mencukupi.");
            return;
        }

        _saldo -= nominal;
    }

    public void CetakSaldo() => Console.WriteLine($"Saldo anda: Rp. {_saldo}");
}