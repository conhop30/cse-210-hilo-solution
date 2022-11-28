class Score {
    private int CurrentScore;

    public Score(int defaultScore) {
        CurrentScore = defaultScore;
    }

    //getter
    public int GetCurrentScore() {
        return CurrentScore;
    }
    //setter
    public void SetCurrentScore(int newScore) {
        if (newScore <0) {
            newScore = 0;
        }
        
        CurrentScore = newScore;
    }
}
