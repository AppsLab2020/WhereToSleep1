using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WhereToSleep.ViewModels
{
    public class PinItemsViewModel
    {
        int _pinCreatedCount = 0;
        readonly ObservableCollection<Location> _locations;

        public IEnumerable Locations => _locations;

        public ICommand AddLocationCommand { get; }
        public ICommand RemoveLocationCommand { get; }
        public ICommand ClearLocationsCommand { get; }
        public ICommand UpdateLocationsCommand { get; }
        public ICommand ReplaceLocationCommand { get; }

        public PinItemsViewModel()
        {
            _locations = new ObservableCollection<Location>()
            {
                new Location("Penzion Relish", "Školská 25/38, 013 13 Rajecké Teplice", new Position(49.12727907146193, 18.682083338488145)),
                new Location("Aphrodite", "Rajecká cesta,013 13 Rajecké Teplice", new Position(49.128930649748284, 18.682633917139224)),
                new Location("Penzion Mlynárka", "64,013 13 Rajecké Teplice", new Position(49.130086886799546, 18.678490097364215)),
                new Location("Hotel Encián", "Osloboditeľov 90,013 13 Rajecké Teplice", new Position(49.1301360630115, 18.683234313551143)),
                new Location("Hotel Diplomat", "1. mája 14,013 13 Rajecké Teplice", new Position(49.12831246275363, 18.689156687005894)),
                new Location("Penzion Villa", "Konská 551,013 13 Rajecké Teplice", new Position(49.125583849327576, 18.674722487334)),
                new Location("Hostinec u Hormadov", "430,430,013 15 Rajecká Lesná", new Position(49.04308093061983, 18.637436293987303)),
                new Location("Penzion Rodus", "Rajecká Lesná 660,013 15 Rajecká Lesná", new Position(49.04578944245049, 18.627694091643036)),
                new Location("Hotel Boss", "Čepiel 1,010 01 Žilina", new Position(49.2233984488473, 18.741897216842215)),
                new Location("Hotel Grand", "Na priekope 127/29,010 01 Žilina", new Position(49.224011240749924, 18.738360655667233)),
                new Location("Boutique Hotel Dubná Skala", "J. M. Hurbana 345/8,010 01 Žilina", new Position(49.22594384235841, 18.73937110171723)),
                new Location("Hotel SLovan", "10,Andreja Kmeťa 658/2,010 01 Žilina", new Position(49.22726362441085, 18.740525897202936)),
                new Location("Holiday Inn", "Športová 2,010 10 Žilina", new Position(49.230467148682585, 18.742014024542488)),
                new Location("Hotel Galileo", "Hlinská 2584/25,010 01 Žilina", new Position(49.208678687078084, 18.735176324796065)),
                new Location("Penzion Anton", "Sv. Cyrila a Metoda,013 01 Teplička nad Váhom", new Position(49.22805098265692, 18.790116656870072)),
                new Location("Hotel Diana", "Stráža 255,013 04 Stráža", new Position(49.22494156577688, 18.907138949216115)),
                new Location("Penzion V Starom Mlyne", "283/41,,SNP,013 05 Belá", new Position(49.23895709072353, 18.94490786715843)),
                new Location("Village resort Hanuliak", "Oslobodenia 1071/118,013 05 Belá", new Position(49.24287910033615, 18.953974121955724)),
                new Location("Penzion Elizabetha", "Námestie Slobody 163,024 01 Kysucké Nové Mesto", new Position(49.30554424187627, 18.788791359583257)),
                new Location("Hotel Kriváň", "Námestie Slobody 104,024 01 Kysucké Nové Mesto", new Position(49.30711120215464, 18.78827637545527)),
                new Location("Chata u Drába", "Oščadnica 769,023 01 Oščadnica", new Position(49.423004658427544, 18.85987476473474)),
                new Location("Hotel Lipa", "Matičné námestie 1138,022 01 Čadca", new Position(49.44116691044949, 18.785276223397716)),
                new Location("Hotel Domes", "Podzávoz,022 01 Čadca", new Position(49.45712584710726, 18.780126382127357)),
                new Location("Hotel Kovox", "Staškov 825,023 53 Staškov", new Position(49.424779965039036, 18.69427161206091)),
                new Location("Penzion HM", "u Smolky č.386,Oščadnica,023 01 Oščadnica", new Position(49.446231160863505, 18.895582972927087)),
                new Location("Privát pod Machom", "Oščadnica 1463,023 01 Oščadnica", new Position(49.445029263253176, 18.89787541046752)),
                new Location("Marko Apartmány", "Oščadnica 1354,023 01 Oščadnica", new Position(49.446060536828064, 18.899909843595186)),
                new Location("Chata pod Grúňom", "Oščadnica 470,023 01 Oščadnica", new Position(49.44333694447399, 18.9144603897661)),
                new Location("Chata pri Moste", "Oščadnica 1346,023 01 Oščadnica", new Position(49.43518562016977, 18.945555649062282)),
                new Location("Chata Snežienka", "Lalíkovci 840,023 01 Oščadnica", new Position(49.434475188581864, 18.939152699854915)),
                new Location("Chata Miroslav", "Oščadnica 1613 Laliky,023 01 Oščadnica", new Position(49.43928168706046, 18.933662327794597)),
                new Location("Chata Kristy", "Oščadnica 789,023 01 Oščadnica", new Position(49.446113969969716, 18.905608737199735)),
                new Location("Zemanov Dvor", "013 11 Lietavská Svinná - Babkov", new Position(49.155655532034196, 18.692914658770526)),
                new Location("Penzión Ruža", "Kľačno 312 97215,972 15", new Position(48.91295945865775, 18.65902135463949)),
                new Location("Penzión Javorina", "Čičmany 216,013 15 Čičmany", new Position(48.95805497845994, 18.51432569053358)),
                new Location("Penzion Manin", "017 05 Kostolec", new Position(49.131248787961674, 18.52955249683866)),
                new Location("Hotel Podhradie", "Považské Podhradie 250,017 04 Považská Bystrica", new Position(49.13834105574253, 18.458358583350904)),
                new Location("Penzión Bystrica", "Žilinská 774/1,017 01 Považská Bystrica", new Position(49.12033230667729, 18.451443665379006)),
                new Location("Sheraton Bratislava", "Pribinova 12,811 09 Bratislava", new Position(48.14229385593443, 17.122549804170106)),
                new Location("Aston Business hotel", "Bajkalská 715,821 09 Bratislava", new Position(48.15374724874535, 17.145895751371675)),
                new Location("Business Hotel Blue Bratislava", "Riazanská 38,831 03 Bratislava", new Position(48.17267313528814, 17.1350189204214)),
                new Location("Hotel Dominika", "Vlastenecké námestie 3,851 01 Petržalka", new Position(48.125608651299736, 17.109640123258675)),
                new Location("Hotel Orlan", "Strojnícka 4542/99,821 05 Ružinov", new Position(48.15626669639593, 17.18306291591783)),
                new Location("DoubleTree by Hilton", "Trnavská cesta 27/A,831 04 Bratislava", new Position(48.16222115829889, 17.1379159739847)),
                new Location("Hotel Modena", "Vlčie hrdlo 2222/1,824 12 Bratislava", new Position(48.13209823092991, 17.17259157200879)),
                new Location("Grobský Dvor", "Vajnorská cesta 715,900 26 Slovenský Grob", new Position(48.2577089967753, 17.263210100135595)),
                new Location("Hotel Rozálka", "Rozálka 9,902 01 Pezinok-Stará hora", new Position(48.29894035302679, 17.253410109498727)),
                new Location("Hotel Maxim", "Bratislavská 52,900 21 Svätý Jur", new Position(48.25171535580829, 17.211215526508596)),
                new Location("Holiday Inn", "Hornopotocna Street 5,917 01 Trnava", new Position(48.38122014334626, 17.586655343035137)),
                new Location("Luxor", "Štúrova 3400/25,917 01 Trnava", new Position(48.38012015441169, 17.57276602622489)),
                new Location("Patriot", "Jeruzalemská 7771/12,917 01 Trnava", new Position(48.38073273631873, 17.590873947305766)),
                new Location("Horská chata Medzihorská", "Medzihorská", new Position(49.10775824378681, 18.761957158020955))
            };

            AddLocationCommand = new Command(AddLocation);
            RemoveLocationCommand = new Command(RemoveLocation);
            ClearLocationsCommand = new Command(() => _locations.Clear());
            UpdateLocationsCommand = new Command(UpdateLocations);
            ReplaceLocationCommand = new Command(ReplaceLocation);
        }

        void AddLocation()
        {
            _locations.Add(NewLocation());
        }

        void RemoveLocation()
        {
            if (_locations.Any())
            {
                _locations.Remove(_locations.First());
            }
        }

        void UpdateLocations()
        {
            if (!_locations.Any())
            {
                return;
            }

            double lastLatitude = _locations.Last().Position.Latitude;
            foreach (Location location in Locations)
            {
                location.Position = new Position(lastLatitude, location.Position.Longitude);
            }
        }

        void ReplaceLocation()
        {
            if (!_locations.Any())
            {
                return;
            }

            _locations[_locations.Count - 1] = NewLocation();
        }

        Location NewLocation()
        {
            _pinCreatedCount++;
            return new Location(
                $"Pin {_pinCreatedCount}", 
                $"Desc {_pinCreatedCount}", 
                RandomPosition(new Position(49.13295184657695, 18.704512050880084), 8, 19));
        }

        private Position RandomPosition(Position position, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
