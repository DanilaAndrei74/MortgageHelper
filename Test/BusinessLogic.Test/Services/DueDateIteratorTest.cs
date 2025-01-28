using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using Xunit;

public class DueDateIteratorTest
{
    [Fact]
    public void AddDate_ShouldStoreDate()
    {
        // Arrange
        var _sut = new DueDateIterator();
        var date = new DateOnly(2025, 3, 10);

        // Act
        _sut.AddDate(date);
        var result = _sut.Next();

        // Assert
        Assert.Equal(date, result);
    }

    [Fact]
    public void Next_ShouldReturnAddedDatesInOrder()
    {
        // Arrange
        var _sut = new DueDateIterator();
        var date1 = new DateOnly(2025, 3, 10);
        var date2 = new DateOnly(2025, 4, 15);
        _sut.AddDate(date1);
        _sut.AddDate(date2);

        // Act & Assert
        Assert.Equal(date1, _sut.Next());
        Assert.Equal(date2, _sut.Next());
        Assert.Equal(date1, _sut.Next()); // Should loop back
    }

    [Fact]
    public void Next_ShouldReturnDefault_WhenNoDates()
    {
        // Arrange
        var _sut = new DueDateIterator();

        // Act
        var result = _sut.Next();

        // Assert
        Assert.Equal(new DateOnly(), result); // Default DateOnly (0001-01-01)
    }

    [Fact]
    public void Reset_ShouldRestartIteration()
    {
        // Arrange
        var _sut = new DueDateIterator();
        _sut.AddDate(new DateOnly(2025, 3, 10));
        _sut.AddDate(new DateOnly(2025, 4, 15));
        _sut.Next(); // Move to second date

        // Act
        _sut.Reset();
        var result = _sut.Next();

        // Assert
        Assert.Equal(new DateOnly(2025, 3, 10), result); // Back to first date
    }

    [Fact]
    public void HardReset_ShouldClearAllDates()
    {
        // Arrange
        var _sut = new DueDateIterator();
        _sut.AddDate(new DateOnly(2025, 3, 10));
        _sut.AddDate(new DateOnly(2025, 4, 15));

        // Act
        _sut.HardReset();
        var result = _sut.Next();

        // Assert
        Assert.Equal(new DateOnly(), result); // No dates should exist
    }
}
