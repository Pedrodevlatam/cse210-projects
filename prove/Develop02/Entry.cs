
using System;
class Entry {
    public string prompt;
    public string response;
    public DateTime date;

    public Entry(string prompt, string response, DateTime date) {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }
}