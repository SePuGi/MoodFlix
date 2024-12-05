export type EmotionsResponse = Emotion[];

export type Emotion = {
  id: number;
  name: string;
  score: number;
}

export type EmotionsState = {
  emotions: Emotion[];
}