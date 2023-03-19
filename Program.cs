// Tugas 3
// Otomobil
Otomobil otomobil = new Otomobil("Camry", "Toyota", 2023, 2487, 250, 60);
otomobil.ShowProperties();
otomobil.ShowFuel();

otomobil.Accelerate(20);
otomobil.ShowSpeed();
otomobil.ShowFuel();

otomobil.Break();
otomobil.ShowSpeed();

otomobil.Accelerate(245);
otomobil.ShowSpeed();
otomobil.ShowFuel();

otomobil.AddFuel(20);
otomobil.ShowFuel();
Console.WriteLine();

// SepedaMotor
SepedaMotor sepedaMotor = new SepedaMotor("Supra X 125R", "Honda", 2012, 125, 110, 12);
sepedaMotor.ShowProperties();
sepedaMotor.ShowFuel();

sepedaMotor.Accelerate(20);
sepedaMotor.ShowSpeed();
sepedaMotor.ShowFuel();

sepedaMotor.Break();
sepedaMotor.ShowSpeed();

sepedaMotor.Accelerate(105);
sepedaMotor.ShowSpeed();
sepedaMotor.ShowFuel();

sepedaMotor.AddFuel(20);
sepedaMotor.ShowFuel();

sepedaMotor.Wheelie();
sepedaMotor.Cornering();
Console.WriteLine();

// Truk
Truk truk = new Truk("truk1", "Volvo", 2000, 2500, 100, 12);
truk.ShowProperties();
truk.DetachTrailer();
truk.AttachTrailer("Reefes");
truk.DetachTrailer();
Console.WriteLine();

// Sedan
Sedan sedan = new Sedan("Civic", "Honda", 2023, 2487, 250, 60, "RWD", "Sport");
sedan.ShowProperties();
sedan.Accelerate(40);
sedan.ShowSpeed();
sedan.ShowFuel();
sedan.Break(10);

sedan.EchoMode();
sedan.Accelerate(10);
sedan.ShowSpeed();
sedan.ShowFuel();
Console.WriteLine();

// Tugas 2
//Mobil Sedan
MobilSedan sedan = new MobilSedan("Camry", "Toyota", 2023, 2487, 250);
sedan.ShowProperties();
sedan.Accelerate(4);
sedan.Break();
sedan.Accelerate(15);
sedan.Accelerate(250);
sedan.Break();
Console.WriteLine();

// Ikan
Ikan nemo = new Ikan("Nemo", 10, "Air Laut", 100, 100);
nemo.ShowProperties();
nemo.Swim(40);
nemo.ShowEnergy();
nemo.Eat(10);
nemo.ShowEnergy();
nemo.Swim(40);
nemo.ShowEnergy();
nemo.Rest();
Console.WriteLine();

// Pion Putih
PionCatur pionPutih = new PionCatur("Pion Putih", true, "A1");
Console.WriteLine(pionPutih.GetName());

pionPutih.MoveForward();
Console.WriteLine(pionPutih.GetLocation());

pionPutih.CaptureToLeft();
Console.WriteLine(pionPutih.GetLocation());

pionPutih.CaptureToRight();
Console.WriteLine(pionPutih.GetLocation());

pionPutih.Promote("Menteri Putih");
Console.WriteLine(pionPutih.GetName());
Console.WriteLine();

// Pion Hitam
PionCatur pionHitam = new PionCatur("Pion Hitam", false, "A8");
Console.WriteLine(pionHitam.GetName());

pionHitam.MoveForward();
Console.WriteLine(pionHitam.GetLocation());

pionHitam.CaptureToRight();
Console.WriteLine(pionHitam.GetLocation());

pionHitam.CaptureToLeft();
Console.WriteLine(pionHitam.GetLocation());

pionHitam.Promote("Menteri Hitam");
Console.WriteLine(pionHitam.GetName());
Console.WriteLine();

// Rekening Bank
RekeningBank nasabah = new RekeningBank("Ivan Wicaksono", 224102021, 500000, "19-03-2023");
Console.WriteLine(nasabah.GetNama());
Console.WriteLine(nasabah.GetNoRekening());
Console.WriteLine(nasabah.GetSaldo());
Console.WriteLine(nasabah.GetTglPembuatan());

nasabah.Setor(100000);
nasabah.CetakSaldo();

nasabah.Tarik(200000);
nasabah.CetakSaldo();