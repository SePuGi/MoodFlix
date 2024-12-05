export type EmotionsResponse = {
  emotions: Emotion[];
  description: string;
};

export type Emotion = {
  id: number;
  name: string;
  score: number;
}

export type EmotionsState = {
  emotions: Emotion[];
}