﻿namespace Konu12KalitimInheritance
{
    internal class Kategori : OrtakOzellikler // Kategori sınıfı OrtakOzellikler sınıfından kalıtım alıyor
    {
        public string? KategoriBanner { get; set; }
        public bool UstMenudeGoster { get; set; }
        public bool YAnMenudeGoster { get; set; }
        public bool AltMenudeGoster { get; set; }
    }
}
