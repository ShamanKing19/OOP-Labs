namespace Laba5;

public interface ISettingsService<T>
{
    T Read(string filepath);
    void Update(T item);
    void Write(string filename, Object data);
}