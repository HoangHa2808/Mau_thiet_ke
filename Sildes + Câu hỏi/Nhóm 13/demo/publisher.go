package main

import (
	"fmt"
	"math/rand"
	"time"
)

// Publisher publishes messages to the broker.
func pricePublisher(broker *Broker) {
	topicKeys := make([]string, 0, len(availableTopics))
	topicValues := make([]string, 0, len(availableTopics))

	for k, v := range availableTopics {
		topicKeys = append(topicKeys, k)
		topicValues = append(topicValues, v)
	}
	for {
		randValue := topicValues[rand.Intn(len(topicValues))] // all topic values.
		msg := fmt.Sprintf("%f", rand.Float64())
		// fmt.Printf("Publishing %s to %s topic\n", msg, randKey)
		go broker.Publish(randValue, msg)
		// Uncomment if you want to broadcast to all topics.
		// go broker.Broadcast(msg, topicValues)
		r := rand.Intn(4)
		time.Sleep(time.Duration(r) * time.Second) //sleep for random secs.
	}
}

func (b *Broker) Publish(topic string, msg string) {
	// publish the message to given topic.
	b.mut.RLock()
	bTopics := b.topics[topic]
	b.mut.RUnlock()
	for _, s := range bTopics {
		m := NewMessage(msg, topic)
		if !s.active {
			return
		}
		go (func(s *Subscriber) {
			s.Signal(m)
		})(s)
	}
}
