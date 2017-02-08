# TriangleAssignment

3 inputs
I1, I2, I3

Equilateral triangle
Correct:
I1 == I2 ∧ I2 == I3

Wrong:
I1 == I2 ∧ I2 != I3

Isosceles
Correct:
I1 == (!I2 ∧ !I3) ∨ I2 == (!I1 ∧ !I3)

Wrong
I1 == I2 ∨ I1 == I3

Scalene
Correct
I1 != I2 ∧ I1 != I3 ∧ I2 != I3

Wrong
I1 + I2 < I3 || I1 +I3 < I2 || I2+I3 < I1
