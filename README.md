# Repo for providing C# lessons

## Lectures and Seminars. Legend

1. Lecture folder name format is as follows:
   - LectureM_TaskN (for example: `Lecture01_Task03`)
2. Seminar folder name format is as follows:
   - SeminarP_TaskQ (for example: `Seminar02_Task01`)
3. Homework folder name format is as follows:
   - SeminarP_HW_TaskQ (for example: `Seminar02_HW_Task01`)

## Seminar03_HW_Task19

## Enter 5-digit number and check if it is a palyndrome

1. Variant I `(Turn number into array)`:
   - Enter 5-digit number as a string and transform it into number
   - Check if the number is 5-digit (less then 100000 and greater then 9999)
   - Convert this number into array of 1-digit integer numbers by cutting last digit of the number in cycle.
   - Compare 1st <=> 5th and 2nd <=> 4th elements of the array (5th element does not matter!). If the equality is true - entered number is a palyndrome.
2. Variant II `(By generating dictionary of the 4-digit palyndromes)`:
