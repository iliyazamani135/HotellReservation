public static class Mapper
{
    public static BookingDtos ToDto(this Booking booking)
    {
        return new BookingDtos
        {
            Id = booking.Id,
            CustomerName = booking.Customer.FullName,
            RoomNumber = booking.Room.Number,
            StartDate = booking.DateRange.StartDate,
            EndDate = booking.DateRange.EndDate
        };
    }
}
