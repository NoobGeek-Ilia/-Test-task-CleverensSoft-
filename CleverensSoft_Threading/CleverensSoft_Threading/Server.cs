using System;
using System.Threading;

public static class Server
{
    // Использовал ReaderWriterLockSlim, так как идеально подходит под условия задачи
    // Обернул в try-finally для освобождения блокировки при любых сценариях

    private static int _count = 0;
    private static readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();

    public static int GetCount()
    {
        try
        {
            _rwLock.EnterReadLock();
            return _count;
        }
        finally
        {
            _rwLock.ExitReadLock();
        }
    }

    public static void AddToCount(int value)
    {
        try
        {
            _rwLock.EnterWriteLock();
            _count += value;
        }
        finally
        {
            _rwLock.ExitWriteLock();
        }
    }
}
