﻿using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(largura, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(largura, '='));
Console.ResetColor();


Random baseRandom = new Random();
		Start:
			 
		Console.WriteLine("Entre com a quantidade dos jogos:");
		if (int.TryParse(Console.ReadLine(), out int jogos) && jogos > 0)
		{
			Start1:
				
			Console.WriteLine("Entre com a quantidade das dezenas:");
			if (int.TryParse(Console.ReadLine(), out int dezenas) && (dezenas > 5 && dezenas < 16))
			{
				int[, ] jogos_ = new int[jogos, dezenas];
				for (int i = 0; i < jogos; i++)
				{
					for (int i_ = 0; i_ < dezenas; i_++)
					{
						jogos_[i, i_] = baseRandom.Next(1, 61);
					}
				}

				for (int u = 0; u < jogos; u++)
				{
					for (int t = 0; t < dezenas; t++)
					{
						
							if (t == 0)
							{
								Console.Write($"O jogo {(u + 1):D2} é = {jogos_[u, t]:D2}-");
							}
							else if (t < dezenas - 1)
							{
								Console.Write($"{jogos_[u, t]:D2}-");
							}
							else
							{
								Console.Write($"{jogos_[u, t]:D2}");
							}
						
					}

					Console.WriteLine();
				}
			}
			else if (dezenas < 6)
			{
				Console.WriteLine("À quantidade de dezenas é inferior ao valor 6");
				
				goto Start1;
			}
			else if (dezenas > 15)
			{
				Console.WriteLine("À quantidade de dezenas é superior ao valor 15");
				goto Start1;
			}else
			{
			    Console.WriteLine("Foi inserido um valor fora dos números inteiros ou um número negativo");
			}
		}
		else
		{
			Console.WriteLine("Foi inserido um valor fora dos números inteiros ou um número negativo");
			goto Start;
		}	
