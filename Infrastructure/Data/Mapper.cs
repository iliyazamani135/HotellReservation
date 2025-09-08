public static class Mapper
{
    public static BookingDto ToDto(this Booking booking)
    {
        return new BookingDto
        {
            Id = booking.Id,
            CustomerName = booking.Customer.FullName,
            RoomNumber = booking.Room.Number,
            StartDate = booking.DateRange.StartDate,
            EndDate = booking.DateRange.EndDate
        };
    }
}
