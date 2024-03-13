using DesignPatterns;

ILectorDatos lectorOriginal = new LeerDatos();

Cliente cliente1 = new Cliente(lectorOriginal);
cliente1.RealizarAoperaciondeLectura();

StreamReader reader = new StreamReader("archivo.txt");
ILectorDatos adaptadorStreamReader = new AdapatadorStreamReader(reader);

Cliente cliente2 = new Cliente(adaptadorStreamReader);
cliente2.RealizarAoperaciondeLectura();

