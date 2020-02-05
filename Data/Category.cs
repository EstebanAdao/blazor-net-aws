using System;

namespace AWS_Blazor.Data
{
	public class Category
	{
		public string Key { get; set; }
		public string Nome { get; set; }
		public string Url { get; set; }
		public long Categoria { get; set; }
		public string NomeCategoria { get; set; }
		public string CorPrimaria { get; set; }
		public string CorSecundaria { get; set; }
		public string BannerDesktop { get; set; }
		public string CardDesktop { get; set; }
		public string BannerMobile { get; set; }
		public string CardMobile { get; set; }
		public string Descricao { get; set; }
		public DateTime DataInclusao { get; set; }
		public string LinkBanner { get; set; }
	}
}
