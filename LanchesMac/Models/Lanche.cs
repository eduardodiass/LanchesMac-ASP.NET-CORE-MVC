﻿namespace LanchesMac.Models
{
    public class Lanche
    {
        
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }

        public string ImagemThumbnaiurl { get; set; }
public bool IsLanchePreferido { get; set; }


    }
}
