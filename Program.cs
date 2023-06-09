﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

class main
{
    static void Main(string[] args)
    {
        KodePos.Kelurahan k = KodePos.Kelurahan.Batununggal;
        Console.WriteLine("Kode pos kelurahan " + k + " adalah " + KodePos.getKodePos(k));
        KodePos.Kelurahan k2 = KodePos.Kelurahan.Mengger;
        Console.WriteLine("Kode pos kelurahan " + k2 + " adalah " + KodePos.getKodePos(k2));
        KodePos.Kelurahan k3 = KodePos.Kelurahan.Samoja;
        Console.WriteLine("Kode pos kelurahan " + k3 + " adalah " + KodePos.getKodePos(k3));

        Console.WriteLine("=======Door Machine=======");

        DoorMachine pintu = new DoorMachine();

        pintu.KunciPintu();
        pintu.BukaPintu();
        pintu.BukaPintu(); 
        pintu.KunciPintu();
        pintu.BukaPintu(); 
    }
}

public class KodePos
{
    public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, 
        Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}
    
    public static int getKodePos(Kelurahan k)
    {
        int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286,
            40286, 40286, 40272, 40274, 40273};
        return kode[(int) k];
    }
}

public class DoorMachine
{
    public enum State {Terkunci, Terbuka };

    private State state = State.Terkunci;

    public void KunciPintu()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu Terkunci");
    }

    public void BukaPintu()
    {
        switch (state)
        {
            case State.Terkunci:
                state = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
                break; 
             case State.Terbuka:
                Console.WriteLine("Pintu tidak terkunci");
                break;
        }
    }
}