Console.Write("Valor da fatura: R$");
decimal fatura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Pagamento mínimo (%): ");
decimal minPct = Convert.ToDecimal(Console.ReadLine());

Console.Write("Taxa de juros (% ao mês): ");
decimal jurosPct = Convert.ToDecimal(Console.ReadLine());

decimal minPag = fatura * minPct / 100;
decimal saldoDevedor = fatura - minPag;
decimal juros = saldoDevedor * jurosPct / 100;
decimal iofMensal = saldoDevedor * 0.0038m;
decimal iofDiario = saldoDevedor * 0.000082m * 30;
decimal proximaFatura = saldoDevedor + juros + iofMensal + iofDiario;
decimal custoRotativo = proximaFatura - saldoDevedor;

Console.WriteLine($"\nPagamento mínimo: R${minPag:0.00}");
Console.WriteLine($"Saldo devedor: R${saldoDevedor:0.00}");
Console.WriteLine($"Juros: R${juros:0.00}");
Console.WriteLine($"IOF Mensal: R${iofMensal:0.00}");
Console.WriteLine($"IOF Diário: R${iofDiario:0.00}");
Console.WriteLine($"Próxima fatura: R${proximaFatura:0.00}");
Console.WriteLine($"Custo do crédito rotativo: R${custoRotativo:0.00}");