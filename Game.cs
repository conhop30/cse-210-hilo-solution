class Game {

    Player player = new Player();

    Score score = new Score(300);

    Deck deck = new Deck();

    Card CurrentCard;

    public Game() {
        CurrentCard = deck.DrawRandomCard();
    }

    public void Play() {

        var keepPlaying = true;
        while (keepPlaying) {

            Console.WriteLine("");
            Console.WriteLine($"The card is: {CurrentCard.Name()}");

            var nextCard = deck.DrawRandomCard();
            var guess = player.Guess();
            var current = score.GetCurrentScore();

            if (guess == "h") {
                if (nextCard.IsHigher(CurrentCard)) {
                    current += 100;
                } else {
                    current -= 75;
                }

            } else if (guess == "l") {
                if (CurrentCard.IsHigher(nextCard)) {
                    current += 100;
                } else {
                    current -= 75;
                }
            }

            score.SetCurrentScore(current);
            Console.WriteLine($"Next card was: {nextCard.Name()}");
            Console.WriteLine($"Yours score is: {score.GetCurrentScore()}");
            CurrentCard = nextCard;

            keepPlaying = player.KeepPlaying();            
        }
    }
}
