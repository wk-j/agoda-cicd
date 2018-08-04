namespace ReactApp.Services {
    public interface INameService {
        string GetName(string title);
    }
    public class NameService : INameService {
        public string GetName(string title) {
            if (string.IsNullOrWhiteSpace(title)) {
                return "John Smith";
            }
            return $"{title} John Smith";
        }
    }
}