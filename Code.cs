// C++ code
//
int tmp = 0;

void setup()
{
  pinMode(A0, INPUT);
  pinMode(13, OUTPUT);
  Serial.begin(9600);

}

void loop()
{
  tmp = -40 + 0.488155 * (analogRead(A0) - 20); // Convert to Degrees Celsius 
  if (tmp >= 25) {
    digitalWrite(13, LOW); // Turn led on
  }
  if (tmp < 25) {
    digitalWrite(13, HIGH); // turn led off
  }
  Serial.println(-40 + 0.488155 * (analogRead(A0) - 20));
  delay(10); // Delay a little bit to improve simulation performance
}