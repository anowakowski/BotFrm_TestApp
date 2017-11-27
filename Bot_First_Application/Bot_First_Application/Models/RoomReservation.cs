using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot_First_Application.Models
{
    public enum BedSizeOptions
    {
        King,
        Queen,
        Single,
        Double
    }

    public enum AmenituesOptions
    {
        Kitchen,
        ExtraTowels,
        GymAccess,
        Wifi
    }

    [Serializable]
    public class RoomReservation
    {
        public BedSizeOptions? BedSize;
        public int? NumberOfOccupants;
        public DateTime? CheckInDate;
        public int? NumberOfDayToStay;
        public List<AmenituesOptions> Amenities;

        public static IForm<RoomReservation> BuildForm()
        {
            return new FormBuilder<RoomReservation>()
                .Message("Welcome to the hotel reservation")
                .Build();
        }
    }
}