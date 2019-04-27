# sample-particle-job
IParticleSystemJobを使用したパーティクルのサンプル

### Unity Version
Unity 2019.1.0f2

CustomData モジュールで定義したカーブアニメーションに沿ってパーティクルカラーを変更
Particle1 : メインスレッド側で処理
Particle2 : IParticleSystemJobを使ってWorkerスレッド側で処理

![demo](https://github.com/aki517/sample-particle-job/wiki/img/particle_job.gif)
