using Modul9_103022400139;
using System;
using System.IO;
using System.Text.Json;

public class BankTransferConfig
{
    private const string ConfigFilePath = "bank_transfer_config.json";

    public string lang { get; set; } = "en";

    public Transfer transfer { get; set; }
    public string[] methods { get; set; }
    public Confirmation confirmation { get; set; }
}
