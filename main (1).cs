using System;
class Program {
  static void Main() {
    while(true)
    {
        Console.WriteLine("Bem-vindo a casa skywalker!");
        Console.WriteLine("O que você deseja ver?\r\n1-Apresentação do Yoda(fundador da casa skywalker)\r\n2-Apresentação da casa skywalker\r\n3-relação casa skywalker");
        int escolha = int.Parse(Console.ReadLine());
        
        switch(escolha){
            case 1:
            
            Console.WriteLine("Yoda, o melhor jedi que já existiu, decidiu montar uma ong para ajudar outros jedis a treinar suas técnicas de voo, sobrevivência e lutas com sabre de luz.");
            
            break;
            
            case 2:
            Console.WriteLine("Aqui está uma breve apresentação da casa skywalker!");
            Console.WriteLine("Aqui os jedis podem descansar, comer, dormir e até mesmo treinar!\r\nÉ como se fosse uma casa para eles, um lugar de acolhimento e conforto\r\nprincipalmente para aqueles que não tem moradia");
            Console.WriteLine("deseja fazer algum tipo de doação, sim ou não?");
            string escolha_legal = Console.ReadLine();
            
            if (escolha_legal == "sim" || escolha_legal == "Sim" || escolha_legal == "S")
            {
              Console.WriteLine("Agradecemos sua doação"); 
              
            }
            else if (escolha_legal == "nao" || escolha_legal == "não" || escolha_legal == "N")
            {
              Console.WriteLine("Sem problemas, agradecemos sua visita");  
            }
            else 
            {
              Console.WriteLine("Digite algo válido");  
            }
            break;
            case 3:
                
            Console.WriteLine("Aqui está a relação do personagem com a entidade");
            Console.WriteLine("Yoda estava cansado de ve a situação de muitos jovens talentosos, então resolveu fundas a casa skywalker! para ajudar essas pessoas\r\na fundação skywalker pode ser acessada por todos que desejarem acessá-la ");
            int doação = 0;
            
            for(int i = 50; i <= 5000; i++)
         {
             if(i % 2 == 0 && i % 3 != 0)
             {
                 doação += i;
                 Console.WriteLine("Esses são os valores que conseguimos arrecadar na casa skywalker!: " +doação);
                 Console.WriteLine("Acima são valores que arrecadamos semanalmente, graças ao púbico.");
             }
         }
            break;
        }
        }
    }
  }