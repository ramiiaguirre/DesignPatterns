# Program Analysis

## Flyweight Pattern (FW) — Overview

| Category | Metric | 10M reps | 100M reps | 1B reps (est.) |
| -------- | ------ | -------- | --------- | -------------- |
| **Memory — RealEstateDeveloper** | Without FW | 0.72 GB | 7.2 GB | ~72 GB |
| | With FW | 288 B | 288 B | 288 B |
| | 🟢 Reduction | **~99.99%** | **~99.99%** | **~99.99%** |
| **Memory — Total** | Without FW | 1.3 GB | 12 GB | ~120 GB |
| | With FW | 0.7 GB | 5.8 GB | ~41 GB |
| | 🟢 Reduction | **~46%** | **~52%** | **~66%** |
| **Time — Flyweight vs Baseline** | Without FW | 0.10 min | 1.22 min | N/A |
| | With FW | 0.04 min | 0.43 min | N/A |
| | 🟢 Speedup | **2.5x faster** | **2.8x faster** | — |
| **Time — Concurrency vs Baseline** | Without FW | 0.10 min | 1.22 min | N/A |
| | With FW + Concurrency | 0.02 min | 0.23 min | N/A |
| | 🟢 Speedup | **5x faster** | **5.3x faster** | — |
| **Time — Concurrency vs FW only** | With FW | 0.04 min | 0.43 min | N/A |
| | With FW + Concurrency | 0.02 min | 0.23 min | N/A |
| | 🟢 Speedup | **2x faster** | **1.9x faster** | — |
| **Instance Count — RealEstateDeveloper** | Without FW | 10,000,000 | 100,000,000 | 1,000,000,000 |
| | With FW | 4 | 4 | 4 |
| | 🟢 Reduction | **99.99996%** | **99.999996%** | **99.9999996%** |

## Detailed Analysis

- **~**  estimated
- **(N/A)** not available

### Without Flyweight

| Repeticiones | Memoria Total | Building Instances | RealEstateDeveloper Instances | Time | Coments |
| --- | --- | --- | --- | --- | --- |
| 10,000,000 | 1.3 GB | 10,000,000 (0.40 GB) | 10,000,000 (0.72 GB) | 0.10 min | |
| 100,000,000 | 12 GB | 100,000,000 (4 GB) | 100,000,000 (7.2 GB) | 1.22 min | Memory's Snapshot was taking long time |
| 1,000,000,000 | ~110-130 GB | 1,000,000,000 (40 GB) | 1,000,000,000 (72 GB) | (N/A) | The program was finished manually because it took a long time |

### With Flyweight

| Repeticiones | Memoria Total | Building Instances | RealEstateDeveloper Instances | Time | Coments |
| --- | --- | --- | --- | --- | --- |
| 10,000,000 | 0.7 GB | 10,000,000 (0.4 GB) | 4 (288 Bytes) | 0.04 min | |
| 100,000,000 | 5.8 GB | 100,000,000 (4 GB) | 4 (288 Bytes) | 0.43 min | |
| 1_000,000,000 | ~41 GB | 1,000,000,000 (40GB) | 4 (288 Bytes) | (N/A) | est. |

### With Flyweight + Concurrence

| Repeticiones | Memoria Total | Building Instances | RealEstateDeveloper Instances | Time | Coments |
| --- | --- | --- | --- | --- | --- |
| 10,000,000 | 0.7 GB | 10,000,000 (0.4 GB) | 4 (288 Bytes) | **0.02 min** | |
| 100,000,000 | 5.6 GB | 100,000,000 (4 GB) | 4 (288 Bytes) | **0.23 min** | |
| 1,000,000,000 | ~41 GB | 1,000,000,000 (40GB) | 4 (288 Bytes) | (N/A) | est. |

## Reference

- Flyweight chapter in "Design Patterns: Elements of Reusable Object-Oriented"
- [RefactoringGuru](https://refactoring.guru/design-patterns/flyweight)
- [Video](https://www.youtube.com/watch?v=RDV0ioVTF4g)