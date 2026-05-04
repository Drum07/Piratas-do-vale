
import React from 'react';
import { motion } from 'framer-motion';
import { Card, CardContent } from '@/components/ui/card';
import { Cpu, Code, Lightbulb } from 'lucide-react';

const personagens = [
  'Steve Jobs',
  'Bill Gates',
  'Steve Wozniak',
  'Paul Allen',
  'Mike Markkula',
  'Gary Kildall',
  'Roberta Williams'
];

export default function PiratasDoValeAnimacao() {
  return (
    <div className="min-h-screen bg-slate-950 text-white p-8 flex flex-col items-center gap-8">
      <motion.h1
        initial={{ opacity: 0, y: -40 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ duration: 1 }}
        className="text-4xl font-bold text-center"
      >
        Piratas do Vale 🚀
      </motion.h1>

      <motion.p
        initial={{ opacity: 0 }}
        animate={{ opacity: 1 }}
        transition={{ delay: 0.8, duration: 1 }}
        className="text-lg text-center max-w-3xl"
      >
        Representação dos principais nomes da tecnologia usando Programação Orientada a Objetos.
      </motion.p>

      <div className="grid md:grid-cols-3 gap-6 w-full max-w-6xl">
        {['Herança', 'Encapsulamento', 'Polimorfismo', 'Abstração'].map((conceito, index) => (
          <motion.div
            key={conceito}
            initial={{ opacity: 0, scale: 0.8 }}
            animate={{ opacity: 1, scale: 1 }}
            transition={{ delay: index * 0.3, duration: 0.6 }}
          >
            <Card className="rounded-2xl shadow-xl bg-slate-800 border-slate-700">
              <CardContent className="p-6 flex flex-col items-center gap-3">
                {index % 3 === 0 ? <Cpu /> : index % 3 === 1 ? <Code /> : <Lightbulb />}
                <h2 className="text-xl font-semibold">{conceito}</h2>
              </CardContent>
            </Card>
          </motion.div>
        ))}
      </div>

      <motion.div
        initial={{ opacity: 0, y: 50 }}
        animate={{ opacity: 1, y: 0 }}
        transition={{ delay: 1.5, duration: 1 }}
        className="w-full max-w-5xl"
      >
        <Card className="bg-slate-900 border-slate-700 rounded-2xl">
          <CardContent className="p-6">
            <h2 className="text-2xl font-bold mb-4">Personagens</h2>
            <div className="grid md:grid-cols-2 gap-3">
              {personagens.map((nome, i) => (
                <motion.div
                  key={nome}
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  transition={{ delay: 2 + i * 0.15 }}
                  className="bg-slate-800 rounded-xl p-3"
                >
                  {nome}
                </motion.div>
              ))}
            </div>
          </CardContent>
        </Card>
      </motion.div>
    </div>
  );
}
